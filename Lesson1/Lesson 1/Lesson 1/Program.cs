// Akıllı Spor Salonu Üyelik Sistemi 

const decimal MembershipFee = 2000m;
const int MonthsInYear = 12;

Console.Write("First Name: ");
string? memberFirstName = Console.ReadLine();

Console.Write("Last Name: ");
string? memberLastName = Console.ReadLine();

Console.Write("Gender (M/F): ");
char memberGender = char.Parse(Console.ReadLine());

Console.Write("Is Student (true/false): ");
bool isStudent = bool.Parse(Console.ReadLine());

Console.Write("Height (meters): ");
double memberHeight = Convert.ToDouble(Console.ReadLine());

Console.Write("Weight (kg): ");
double memberWeight = Convert.ToDouble(Console.ReadLine());

Console.Write("Membership ID: ");
int membershipID = int.Parse(Console.ReadLine());

Console.Write("Membership Type: ");
string? membershipType = Console.ReadLine();

decimal yearlyCost = MembershipFee * MonthsInYear;

double bodyMassIndex = memberWeight / (memberHeight * memberHeight);

Console.WriteLine();
Console.WriteLine("==== GYM MEMBER INFORMATION ====");
Console.WriteLine("Member ID        :" + membershipID);
Console.WriteLine("Full Name        :" + memberFirstName+" "+memberLastName);
Console.WriteLine("Gender           :" + memberGender);
Console.WriteLine("Student Status   :" + isStudent);
Console.WriteLine("Membership Type  :" + membershipType);
Console.WriteLine("Monthly Fee      :" + MembershipFee+" TL");
Console.WriteLine("Yearly Cost      :" + yearlyCost+" TL");
Console.WriteLine("Height (m)       :" + memberHeight);
Console.WriteLine("Weight (kg)      :" + memberWeight);
Console.WriteLine("BMI              :" + bodyMassIndex);
Console.WriteLine("====================================");
