Console.WriteLine("TIPO DE INCIDENTE\n1:Malware\n2:Phishing\n3:Acceso no autorizado\n4:Fuga de información");
Console.WriteLine("Ingrese el tipo de incidente:");
int incidente = int.Parse(Console.ReadLine());
Console.WriteLine("ACTIVO AFECTADO\n1:PC\n2:Servidor\n3:Base de datos\n4:Red");
Console.WriteLine("Ingrese el activo afectado:");
int activo = int.Parse(Console.ReadLine());
Console.WriteLine("DATOS COMPROMETIDOS\n1:Ninguno\n2:Internos\n3:Personales\n4:Financieros");
Console.WriteLine("Ingrese los datos comprometidos:");
int datos = int.Parse(Console.ReadLine());


