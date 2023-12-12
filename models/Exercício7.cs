//  7 - Implementar um programa que valide um CPF

// class Program
// {
//     static void Main()
//     {
//         string cpf = "12345678900";
//         bool cpfValido = ValidarCPF(cpf);        
//         if (cpfValido)
//         {
//             Console.WriteLine("CPF válido!");
//         }
//         else
//         {
//             Console.WriteLine("CPF inválido!");
//         }        
//     }
//     static bool ValidarCPF(string cpf)
//     {
//         cpf = new string(cpf.Where(char.IsDigit).ToArray());
//         if (cpf.Length !=11)
//         {
//             return false;
//         }
//         if (cpf.Distinct().Count() == 1)
//         {
//             return false;
//         }
//         else
//         {
//             return true;
//         }
//     }

// }