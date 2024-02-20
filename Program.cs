class NoDuplicates {
    static void Main(string[] args) {
        Console.WriteLine("Enter line: ");
        string input = Console.ReadLine() ?? string.Empty;

        if (input.Length > 80) {
            Console.WriteLine("Input exceeds limit");
            return;
        }

        if (!string.IsNullOrEmpty(input) && input.Any(char.IsUpper)) {
            var words = input.Split(' ');
            var wordSet = new HashSet<string>();
            bool duplicate = false;

            foreach (var word in words) {
                if (!wordSet.Add(word)) {
                    duplicate = true;
                    break;
                }
            }
            Console.WriteLine(duplicate ? "NO" : "YES");
        }
        else {
            Console.WriteLine("Invalid input");
        }
    }
}
