double sum=0;
int counter=-1;
int number;



do
{
    
    
        System.Console.WriteLine("nomarat ra vared konid");
        number=Convert.ToInt32(Console.ReadLine());
        sum=sum+number;
        counter++;
        
    
    
    
} while (number !=0);

System.Console.WriteLine(sum/counter);