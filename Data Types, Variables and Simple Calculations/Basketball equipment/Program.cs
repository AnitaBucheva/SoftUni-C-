int annualFeeLv = int.Parse(Console.ReadLine());

double sneakersPriceLv = annualFeeLv - (annualFeeLv * 0.4);
double teemPriceLv = sneakersPriceLv - (sneakersPriceLv * 0.2);
double ballPriceLv = (1.0 / 4) * teemPriceLv;
double accsessoaries = (1.0 / 5) * ballPriceLv;

double totalPrice = annualFeeLv + sneakersPriceLv + teemPriceLv + ballPriceLv + accsessoaries;
Console.WriteLine(totalPrice);