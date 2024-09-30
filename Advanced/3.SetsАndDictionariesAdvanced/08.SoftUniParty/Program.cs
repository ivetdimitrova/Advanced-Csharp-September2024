namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservations = new HashSet<string>();
            HashSet<string> vipReservations = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (input.Length == 8)
                {
                    if (input[0] >= 48 && input[0] <= 57)
                    {
                      
                            vipReservations.Add(input);
                    }
                    else
                    {
                        reservations.Add(input);
                    }
                }
               
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (reservations.Contains(input))
                {
                    reservations.Remove(input);
                }
                else if (vipReservations.Contains(input))
                {
                    vipReservations.Remove(input);
                }
            }

            Console.WriteLine(reservations.Count + vipReservations.Count);
            foreach (string reservation in vipReservations)
            {
                Console.WriteLine(reservation);
            }
            foreach (string reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
