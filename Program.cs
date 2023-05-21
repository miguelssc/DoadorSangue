double idade;
Console.WriteLine("------doador de Sangue-----");
Console.WriteLine();
Console.WriteLine("qual a sua idade?");
idade =Convert.ToDouble(Console.ReadLine());
if(idade > 67 || idade< 18){
Console.WriteLine("voce nao pode ser doador");
}
else{
    Console.WriteLine("voce pode ser um doador");
}