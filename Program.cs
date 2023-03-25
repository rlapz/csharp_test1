using System;

// Don't use indentation for the `namespace` (avoid nested-hell)
namespace ConsoleApplication {

// A regular nested loop (Not sure what is this)
class Test1 {
	public void Run() {
		for (int i = 1; i <= 3; i++) {
			for (int j = 1; j <= 5; j++) {
				Console.Write(j);
				if (j == 5) {
					Console.Write("\n");
					for (int k = 1; k <= 1; k++) {
						for (int l = 5; l >= 1; l--) {
							Console.Write(l);
							if (l == 1) {
								Console.Write("\n");
							}

						}


					}

				}

			}

		}
	}
}

// segitiga sama siku (maybe)
class Test2 {
	public void Run() {
		for (int i=1; i<=5; i++) {
			for (int j=4; j>=i; j--) {
				Console.Write(" ");
			}

			for (int k=1; k<=i; k++) {
				Console.Write("* ");
			}

			Console.Write("\n");
		}
	}
}

// deret fibonacci dengan input 10
class Test3 {
	public void Run() {
		int x = 0, y = 1, z = 1;

		Console.Write("Masukkan jumlah bilangan fibonacci = ");
		int jumlah = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < jumlah; i++) {
			Console.Write(z + " ");
			z = x + y;
			x = y;
			y = z;
		}

		Console.Read();
	}
}

class Program {
	public static void Main(string[] args) {
		// running Test1
		Console.WriteLine("Running `Test1`...");
		var t1 = new Test1();
		t1.Run();

		// running Test2
		Console.WriteLine("\nRunning `Test2`...");
		var t2 = new Test2();
		t2.Run();

		// running Test3
		Console.WriteLine("\nRunning `Test3`...");
		var t3 = new Test3();
		t3.Run();
	}
}

} // namespace ConsoleApplication
