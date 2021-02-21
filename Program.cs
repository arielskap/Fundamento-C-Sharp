using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;
namespace EscuelaProyecto
{
	class Program
	{
		static void Main(string[] args)
		{
			var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogota");
			// var arregloCursos = new Curso[3]{
			// 	new Curso(){Nombre = "101"},
			// 	new Curso(){Nombre = "201"},
			// 	new Curso(){Nombre = "301"}
			// };
			// Curso[] arregloCursos = {
			// 	new Curso(){Nombre = "101"},
			// 	new Curso(){Nombre = "201"},
			// 	new Curso(){Nombre = "301"}
			// };
			escuela.Cursos = new List<Curso>(){
				new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
				new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
				new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana}
			};

			escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
			escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });
			var otraColeccion = new List<Curso>(){
				new Curso(){Nombre = "401", Jornada = TiposJornada.Mañana},
				new Curso(){Nombre = "501", Jornada = TiposJornada.Mañana},
				new Curso(){Nombre = "502", Jornada = TiposJornada.Tarde}
			};
			// Curso tmp = new Curso{Nombre = "101-Vacacional", Jornada = TiposJornada.Noche};
			escuela.Cursos.AddRange(otraColeccion);
			// escuela.Cursos.Add(tmp);
			ImprimirCursosEscuela(escuela);

			// Formas de remover
			// WriteLine("Curso.Hash" + tmp.GetHashCode());
			// escuela.Cursos.Remove(tmp);
			// Predicate<Curso> miAlgoritmo = Predicado;
			// escuela.Cursos.RemoveAll(Predicado);
			// escuela.Cursos.RemoveAll(delegate (Curso cur)
			// {
			// 	return cur.Nombre == "301";
			// });
			escuela.Cursos.RemoveAll((cur) => cur.Nombre == "301");
			escuela.Cursos.RemoveAll((cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);

			// otraColeccion.Clear();
			ImprimirCursosEscuela(escuela);
			// WriteLine("======================");
			WriteLine(new string('=', 50));
		}

		// private static bool Predicado(Curso curobj)
		// {
		// 	return curobj.Nombre == "301";
		// }

		///<SUMMARY>
		///
		///
		private static void ImprimirCursosEscuela(Escuela escuela)
		{
			WriteLine(new string('=', 50));
			WriteLine("Cursos de la Escuela");
			WriteLine(new string('=', 50));

			// if (escuela != null && escuela.Cursos != null)
			if (escuela?.Cursos != null)
			{
				foreach (var curso in escuela.Cursos)
				{
					WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
				}
			}
		}

		private static void ImprimirCursosWhile(Curso[] arregloCursos)
		{
			int contador = 0;
			while (contador < arregloCursos.Length)
			{
				WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
				contador++;
			}
		}
		private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
		{
			int contador = 0;
			do
			{
				WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
				contador++;
			} while (contador < arregloCursos.Length);
		}
		private static void ImprimirCursosFor(Curso[] arregloCursos)
		{
			for (int i = 0; i < arregloCursos.Length; i++)
			{
				WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");
			}
		}
		private static void ImprimirCursosForEach(Curso[] arregloCursos)
		{
			foreach (var curso in arregloCursos)
			{
				WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
			}
		}
	}
}
