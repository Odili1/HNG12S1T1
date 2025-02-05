namespace HNG12S1T1.Services
{
    public class NumberService
    {
        private readonly HttpClient _httpClient;

        public NumberService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i < num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
         }

        private bool IsPerfect(int num)
        {
            int sum = Enumerable.Range(1, num / 2).Where(i => num % i == 0).Sum();
            return sum == num;
        }

        private bool IsArmstrong(int num)
        {
            int sum = num.ToString().Sum(i => (int)Math.Pow(i - '0', num.ToString().Length));
            return sum == num;
        }

        private int GetDigitSum(int num)
        {
            return num.ToString().Sum(i => i - '0');
        }

        private async Task<string> GetFunFact(int num)
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"http://numbersapi.com/{num}/math");
                return response ?? "No fun fact available";
            }catch
            {
                return "No fun fact available";
            }
        }

        public async Task<object> ClassifyNumber(string input)
        {
            if (!int.TryParse(input, out int number))
            {
                return new { number = input, error = true };
            }

            var properties = new List<string>();
            if (IsArmstrong(number)) properties.Add("armstrong");
            properties.Add(number % 2 == 0 ? "even" : "odd");
            
            var funFact = await GetFunFact(number);

            return new
            {
                number,
                is_prime = IsPrime(number),
                is_perfect = IsPerfect(number),
                properties,
                digit_sum = GetDigitSum(number),
                funFact,
            };
        }

        
    }
}
