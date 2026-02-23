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
                else if (datos == 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad baja");
                }
                else if (datos == 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad media");
                }
                break;
            }
        case 2:
            {
                if (datos != 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad alta");
                    if (activo == 1)
                    {
                        Console.WriteLine("Limitar el acceso");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Alertar a los administradores y solicitar verificaciones");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Validar a cada usuario");
                    }
                }
                else if (datos != 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad crítica");
                    if (activo == 1)
                    {
                        Console.WriteLine("Limitar acceso");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Solicitar doble verificación cada vez que se ingrese");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Respaldar información y validar acceso");
                    }
                }
                else if (datos == 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad baja");
                }
                else if (datos == 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad media");
                }
                break;
            }
        case 3:
            {
                if (datos != 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad alta");
                    if (activo == 1)
                    {
                        Console.WriteLine("Verificar información de ingreso");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Autenticar credenciales");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Implementar otras opciones de acceso");
                    }
                }
                else if (datos != 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad crítica");
                    if (activo == 1)
                    {
                        Console.WriteLine("Verificar info de ingreso");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Autenticar credenciales");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Verificar información almacenada e implementar otras opciones de acceso");
                    }
                }
                else if (datos == 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad baja");
                }
                else if (datos == 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad media");
                }
                break;
            }
        case 4:
            {
                if (datos != 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad alta");
                    if (activo == 1)
                    {
                        Console.WriteLine("Bloquear dispositivo");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Enviar copia de seguridad al administrador");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Bloquear acceso");
                    }
                }
                else if (datos != 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad crítica");
                    if (activo == 1)
                    {
                        Console.WriteLine("Bloquear dispositivo y enviar copia de seguridad a la nube");
                    }
                    else if (activo == 2 || activo == 4)
                    {
                        Console.WriteLine("Bloquear información y solicitar verificación");
                    }
                    else if (activo == 3)
                    {
                        Console.WriteLine("Subir información a la nube y bloquear acceso");
                    }
                }
                else if (datos == 1 && persistencia == 2)
                {
                    Console.WriteLine("Severidad baja");
                }
                else if (datos == 1 && persistencia == 1)
                {
                    Console.WriteLine("Severidad media");
                }
                break;
            }
        default:
            {
                Console.WriteLine("Ingrese nuevamente los datos");
                break;
            }
    }
}
else
{
    Console.WriteLine("Datos inválidos");
}