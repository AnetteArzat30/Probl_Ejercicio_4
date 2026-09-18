
            Console.WriteLine("==================================================================");
            Console.WriteLine("EJERCICIO 4: Prueba de 8 mediciones de corriente en un actuador");
            Console.WriteLine("==================================================================\n");

            double suma = 0;
            int normales = 0;
            int sobrecorrientes = 0;
            const int TOTAL_MEDICIONES = 8;

            for (int i = 1; i <= TOTAL_MEDICIONES; i++)
            {
                Console.Write($"Ingrese la corriente de la medición #{i} (A): ");
                double corriente = Convert.ToDouble(Console.ReadLine());
                suma += corriente;

                if (corriente <= 5)
                {
                    Console.WriteLine(" -> MEDICIÓN NORMAL");
                    normales++;
                }
                else
                {
                    Console.WriteLine(" -> SOBRECORRIENTE DETECTADA");
                    sobrecorrientes++;
                }
            }

            double promedio = suma / TOTAL_MEDICIONES;

            Console.WriteLine("\n================ RESUMEN DE LA PRUEBA ================");
            Console.WriteLine($"Corriente promedio: {promedio:F2} A");
            Console.WriteLine($"Mediciones normales: {normales}");
            Console.WriteLine($"Mediciones con sobrecorriente: {sobrecorrientes}");

            if (sobrecorrientes == 0)
            {
                Console.WriteLine("Resultado General: ACTUADOR APROBADO");
            }
            else
            {
                Console.WriteLine("Resultado General: EL ACTUADOR REQUIERE REVISIÓN");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
   