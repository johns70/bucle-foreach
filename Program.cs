namespace bucle_foreach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Array implicito
			var numeros = new[] { 12, 25, 23.3, 32.66 };

			//Array anonimo
			/*			var persona = new[]
						{
							new{Nombre = "Julia", edad = 22},
							new{Nombre = "Carmen", edad = 32}
						};*/

			//Array de Objeto/clase
			/*Empleados[] arrEmpleados = new Empleados[4];

			Empleados Ashbyl = new Empleados("Ashbyl", 21);

			arrEmpleados[0] = new Empleados("Roys", 33);
			arrEmpleados[1] = new Empleados("Tara", 22);
			arrEmpleados[2] = Ashbyl;
			arrEmpleados[3] = new Empleados("Toby", 28);*/


			for (int i = 0; i <numeros.Length; i++)
			{
				Console.WriteLine(numeros[i]);
			}


			/*foreach(Empleados empleado in arrEmpleados)
			{
				Console.WriteLine(empleado.getInfo());
			}*/
		}

		class Empleados
		{
			public Empleados(string Name, int Age)
			{
				this.Name = Name;
				this.Age = Age;
			}

			public string getInfo()
			{
				return $"Name: {Name} || Age: {Age}";
			}

			private string Name;
			private int Age;
		}
	}
}