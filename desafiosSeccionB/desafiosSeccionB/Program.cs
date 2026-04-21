/*
 * Creado por SharpDevelop.
 * Usuario: katiuscalugo
 * Fecha: 18/4/2026
 * Hora: 7:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace desafiosSeccionB
{
	class Program
	{
		public static void Main(string[] args)
		{
			Program miPrograma = new Program();
			
			//Simulacion de entrada:usuario;clave
			
			Console.WriteLine("Ingrese su usuario y su clave");
			string entrada = Console.ReadLine();
			string [] partes = entrada.Split(';');
			
			Console.WriteLine("Presione una tecla para salir...");
			Console.ReadKey();
		}
		
		public void ValidarSeguridad(string entrada)
		{	
				string[] partes = entrada.Split(';');
				
				//Validar que existan al menos dos partes (usuario y clave)
				
				if (partes.Length >= 2)
				{
					string clave = partes[1];
					
					if (clave.Contains("123"))
					{
						using (StreamWriter writer = new StreamWriter("seguridad.txt", true))
						{
							writer.WriteLine("Clave debil detectada");
						}
						Console.WriteLine("Alerta: Clave insegura registrada.");
					}
				}
			}
		}
	}
