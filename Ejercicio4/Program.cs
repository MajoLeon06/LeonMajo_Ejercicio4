Console.WriteLine("TIPO DE INCIDENTE\n1:Malware\n2:Phishing\n3:Acceso no autorizado\n4:Fuga de información");
Console.WriteLine("Ingrese el tipo de incidente:");
int incidente = int.Parse(Console.ReadLine());
Console.WriteLine("ACTIVO AFECTADO\n1:PC\n2:Servidor\n3:Base de datos\n4:Red");
Console.WriteLine("Ingrese el activo afectado:");
int activo = int.Parse(Console.ReadLine());
Console.WriteLine("DATOS COMPROMETIDOS\n1:Ninguno\n2:Internos\n3:Personales\n4:Financieros");
Console.WriteLine("Ingrese los datos comprometidos:");
int datos = int.Parse(Console.ReadLine());
Console.WriteLine("¿Persistencia detectada? 1:Si 2:No");
int persistencia = int.Parse(Console.ReadLine());
Console.WriteLine("Número de usuarios afectados:");
int users = int.Parse(Console.ReadLine());
if (incidente >= 1 && incidente <= 4 && activo >= 1 && activo <= 4 && datos >= 1 && datos <= 4 && persistencia >= 1 && persistencia <= 2)
{
    switch (incidente)
    {
        case 1:
            {
                if (datos != 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad alta");
                    if (activo == 1)
                    {
                        Console.WriteLine("Instalar antivirus");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Revisar vulnerabilidades");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Respaldar información");
                    }
                }
                else if (datos != 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad crítica");
                    if (activo == 1)
                    {
                        Console.WriteLine("Instalar antivirus y recuperar información");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Revisar vulnerabilidades");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Respaldar información y descargar copia de seguridad previa");
                    }
                }
                else if (datos==1 && persistencia==2)
                {
                    Console.WriteLine("Severidad baja");
                }
                else if (datos==1 && persistencia==1)
                {
                    Console.WriteLine("Severidad media");
                }
                break;
            }
    }
}