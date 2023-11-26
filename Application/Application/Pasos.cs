namespace CódigoFiguras
{
    public class Pasos
    {
        public void PasosTriangulo()
        {
            Console.WriteLine("Para calcular el área de un círculo, sigue estos cinco pasos simples. Primero, mide el radio del ");
            Console.WriteLine("círculo, que es la distancia desde el centro hasta la circunferencia. Luego, eleva al cuadrado ese");
            Console.WriteLine("valor multiplicándolo por sí mismo. Después, multiplica el resultado por la constante π (pi), que es");
            Console.WriteLine("aproximadamente 3.14159. El producto obtenido es el área del círculo en unidades cuadradas. En ");
            Console.WriteLine("resum en, la fórmula es \r\n�\r\n=\r\n�\r\n�\r\n2\r\nA=πr \r\n2\r\n , donde \r\n�\r\nA es el área y \r\n�\r\nr es el radio del círculo. ");
        }
        public void PasosPerimetroTriangulo()
        {
            Console.WriteLine("Calcular el perímetro de un triángulo es un proceso que implica la suma de las longitudes de sus tres lados.");
            Console.WriteLine("Mide la longitud de cada lado del triángulo, llamados a, b y c. Luego, utiliza la fórmula Perímetro = a + b + c");
            Console.WriteLine("para encontrar el perímetro en la unidad de medida de los lados. En resumen, midiendo cada lado y sumándolos,");
            Console.WriteLine("puedes calcular fácilmente el perímetro de un triángulo.");
        }

        public void PasosCirculo()
        {
            Console.WriteLine("Calcular el área de un círculo es un proceso sencillo que involucra cinco pasos. En primer lugar,");
            Console.WriteLine("mide el radio del círculo, que es la distancia desde el centro hasta cualquier punto en la circunferencia.");
            Console.WriteLine("A continuación, eleva al cuadrado ese valor multiplicándolo por sí mismo. Luego, multiplica el resultado");
            Console.WriteLine("por la constante π (pi), aproximadamente 3.14159. La multiplicación da como resultado el área del círculo");
            Console.WriteLine("en unidades cuadradas, siendo la fórmula A = πr^2, donde A representa el área y r el radio del círculo.");
            Console.WriteLine("En resumen, estos pasos te permiten encontrar fácilmente el área de un círculo, proporcionando una manera");
            Console.WriteLine("clara y eficiente de realizar el cálculo.");
        }
        public void PasosPerimetroCirculo()
        {
            Console.WriteLine("Calcular el perímetro de un círculo es un proceso que implica la medición de su circunferencia. La fórmula");
            Console.WriteLine("para el perímetro de un círculo es P = 2 * π * r, donde P es el perímetro, π es la constante pi (aproximadamente");
            Console.WriteLine("3.14159) y r es el radio del círculo. Mide el radio y utiliza esta fórmula para encontrar el perímetro en la");
            Console.WriteLine("unidad de medida del radio. En resumen, midiendo el radio y aplicando la fórmula, puedes calcular fácilmente");
            Console.WriteLine("el perímetro de un círculo.");
        }
        public void PasosElipse()
        {
            Console.WriteLine("Calcular el área de una elipse implica seguir estos pasos simples. Primero, mide los semiejes de la elipse,");
            Console.WriteLine("que son las distancias desde el centro hasta los puntos en la circunferencia. Luego, eleva al cuadrado cada");
            Console.WriteLine("semieje multiplicándolos por sí mismos. Después, multiplica ambos resultados por la constante π (pi), que es");
            Console.WriteLine("aproximadamente 3.14159. Finalmente, multiplica esos productos y obtén el área de la elipse en unidades cuadradas.");
            Console.WriteLine("En resumen, la fórmula es A = π * a * b, donde A es el área, y a y b son los semiejes de la elipse.");
        }
        public void PasosPerimetroElipse()
        {
            Console.WriteLine("Calcular el perímetro de una elipse es un proceso que implica la medición de su circunferencia aproximada.");
            Console.WriteLine("Dado que la fórmula exacta para el perímetro de una elipse no tiene una solución analítica simple,");
            Console.WriteLine("puedes utilizar una aproximación, que se calcula como P ≈ π * (a + b), donde P es el perímetro,");
            Console.WriteLine("π es la constante pi (aproximadamente 3.14159), a y b son los semiejes de la elipse.");
            Console.WriteLine("Mide los semiejes de la elipse y utiliza la fórmula para encontrar el perímetro aproximado.");
            Console.WriteLine("En resumen, midiendo los semiejes y aplicando la fórmula, puedes calcular aproximadamente el perímetro de una elipse.");
        }

        public void PasosPoligonoRegular()
        {
            Console.WriteLine("Calcular el área de un polígono regular implica seguir estos pasos sencillos. En primer lugar, mide la longitud");
            Console.WriteLine("de un lado del polígono, que es la distancia entre dos vértices consecutivos. Luego, utiliza la fórmula:");
            Console.WriteLine("A = (n * s^2) / (4 * tan(π/n)), donde A es el área, n es el número de lados y s es la longitud del lado.");
            Console.WriteLine("En esta fórmula, tan representa la función tangente trigonométrica y π es la constante pi, aproximadamente 3.14159.");
            Console.WriteLine("Calcula el valor dentro de los paréntesis, y luego divide por 4 veces la tangente del ángulo formado por");
            Console.WriteLine("un vértice del polígono y el centro del polígono. Este resultado te dará el área del polígono regular en");
            Console.WriteLine("unidades cuadradas. En resumen, estos pasos proporcionan una manera clara y eficiente de realizar el cálculo.");
        }
        public void PasosPerimetroPoligonoRegular(int numeroLados, double longitudLado)
        {
            Console.WriteLine($"Calcular el perímetro de un polígono regular es un proceso que implica la suma de las longitudes de sus {numeroLados} lados.");
            Console.WriteLine($"Mide la longitud de uno de los lados del polígono, llamada 'lado', y utiliza la fórmula Perímetro = {numeroLados} * lado");
            Console.WriteLine($"para encontrar el perímetro en la unidad de medida de la longitud del lado. En resumen, midiendo cada lado y sumándolos,");
            Console.WriteLine($"puedes calcular fácilmente el perímetro de un polígono regular.");
        }

        public void PasosRectangulo()
        {
            Console.WriteLine("Calcular el área de un rectángulo es un proceso simple que implica dos pasos. Primero, mide la longitud");
            Console.WriteLine("de un lado del rectángulo, que llamaremos 'base', y la longitud del otro lado, que llamaremos 'altura'.");
            Console.WriteLine("Luego, utiliza la fórmula A = base * altura para encontrar el área del rectángulo en unidades cuadradas.");
            Console.WriteLine("En resumen, multiplicar la base por la altura proporciona el área del rectángulo de manera directa.");
        }

        public void PasosPerimetroRectangulo(double longitudBase, double longitudAltura)
        {
            Console.WriteLine("Calcular el perímetro de un rectángulo es un proceso que implica la suma de las longitudes de sus cuatro lados.");
            Console.WriteLine($"Mide la longitud de la base del rectángulo, llamada 'base', y la longitud de la altura, llamada 'altura'.");
            Console.WriteLine($"Luego, utiliza la fórmula Perímetro = 2 * (base + altura) para encontrar el perímetro en la unidad de medida de las longitudes.");
            Console.WriteLine("En resumen, midiendo la base y la altura y aplicando la fórmula, puedes calcular fácilmente el perímetro de un rectángulo.");
        }

        public void PasosRombo()
        {
            Console.WriteLine("Calcular el área de un rombo es un proceso que involucra dos pasos clave. Primero, mide la longitud de las");
            Console.WriteLine("diagonales mayor y menor del rombo. Luego, utiliza la fórmula A = (diagonalMayor * diagonalMenor) / 2 para");
            Console.WriteLine("encontrar el área del rombo en unidades cuadradas. Esta fórmula deriva del hecho de que el área de un rombo");
            Console.WriteLine("es la mitad del producto de sus diagonales. En resumen, midiendo las diagonales y aplicando la fórmula, puedes");
            Console.WriteLine("calcular fácilmente el área de un rombo.");
        }
        public void PasosPerimetroRombo(double longitudDiagonalMayor, double longitudDiagonalMenor)
        {
            Console.WriteLine("Calcular el perímetro de un rombo es un proceso que implica la suma de las longitudes de sus cuatro lados.");
            Console.WriteLine($"Mide la longitud de la diagonal mayor del rombo, llamada 'diagonalMayor', y la longitud de la diagonal menor,");
            Console.WriteLine($"llamada 'diagonalMenor'. Luego, utiliza la fórmula Perímetro = 2 * (sqrt((diagonalMayor/2)^2 + (diagonalMenor/2)^2))");
            Console.WriteLine($"para encontrar el perímetro en la unidad de medida de las longitudes de las diagonales.");
            Console.WriteLine("En resumen, midiendo las diagonales y aplicando la fórmula, puedes calcular fácilmente el perímetro de un rombo.");
        }
        public void PasosRomboide()
        {
            Console.WriteLine("Calcular el área de un romboide es un proceso que implica dos pasos fundamentales. Primero, mide la longitud");
            Console.WriteLine("de la base del romboide y la altura perpendicular a esa base. Luego, utiliza la fórmula A = base * altura para");
            Console.WriteLine("encontrar el área del romboide en unidades cuadradas. La base es la longitud de un lado del romboide, y la altura");
            Console.WriteLine("es la distancia perpendicular desde la base hasta el lado opuesto. En resumen, midiendo la base y la altura y");
            Console.WriteLine("aplicando la fórmula, puedes calcular fácilmente el área de un romboide.");
        }

        public void PasosPerimetroRomboide(double longitudBase, double longitudLadoAdyacente)
        {
            Console.WriteLine("Calcular el perímetro de un romboide es un proceso que implica la suma de las longitudes de sus cuatro lados.");
            Console.WriteLine($"Mide la longitud de la base del romboide, llamada 'base', y la longitud de un lado adyacente, llamado 'lado adyacente'.");
            Console.WriteLine($"Luego, utiliza la fórmula Perímetro = 2 * (base + lado adyacente) para encontrar el perímetro en la unidad de medida de las longitudes.");
            Console.WriteLine("En resumen, midiendo la base y el lado adyacente y aplicando la fórmula, puedes calcular fácilmente el perímetro de un romboide.");
        }
        public void PasosTrapecio()
        {
            Console.WriteLine("Calcular el área de un trapecio es un proceso que involucra dos pasos esenciales. Primero, mide la longitud");
            Console.WriteLine("de las bases del trapecio, llamadas baseMayor y baseMenor, y la altura perpendicular a ambas bases. Luego,");
            Console.WriteLine("utiliza la fórmula A = (baseMayor + baseMenor) * altura / 2 para encontrar el área del trapecio en unidades");
            Console.WriteLine("cuadradas. La altura es la distancia perpendicular entre las bases. En resumen, midiendo las bases y la altura,");
            Console.WriteLine("y aplicando la fórmula, puedes calcular fácilmente el área de un trapecio.");
        }

        public void PasosPerimetroTrapecio(double longitudBaseMayor, double longitudBaseMenor, double longitudLado1, double longitudLado2)
        {
            Console.WriteLine("Calcular el perímetro de un trapecio es un proceso que implica la suma de las longitudes de sus cuatro lados.");
            Console.WriteLine($"Mide la longitud de la base mayor, llamada 'baseMayor', la longitud de la base menor, llamada 'baseMenor',");
            Console.WriteLine($"y las longitudes de los lados no paralelos, llamados 'lado1' y 'lado2'. Luego, utiliza la fórmula");
            Console.WriteLine($"Perímetro = baseMayor + baseMenor + lado1 + lado2 para encontrar el perímetro en la unidad de medida de las longitudes.");
            Console.WriteLine("En resumen, midiendo las bases y los lados no paralelos y aplicando la fórmula, puedes calcular fácilmente el perímetro de un trapecio.");
        }
        public void PasosTrapezoideConParalelos()
        {
            Console.WriteLine("Calcular el área de un trapezoide con un par de lados paralelos es un proceso que implica dos pasos clave.");
            Console.WriteLine("Primero, mide la longitud de las bases paralelas, llamadas baseMayor y baseMenor, y la altura perpendicular");
            Console.WriteLine("a ambas bases. Luego, utiliza la fórmula A = (baseMayor + baseMenor) * altura / 2 para encontrar el área del");
            Console.WriteLine("trapezoide en unidades cuadradas. La altura es la distancia perpendicular entre las bases. En resumen, midiendo");
            Console.WriteLine("las bases y la altura, y aplicando la fórmula, puedes calcular fácilmente el área de un trapezoide con un par");
            Console.WriteLine("de lados paralelos.");
        }

        public void PasosTrapezoideSinParalelos()
        {
            Console.WriteLine("Calcular el área de un trapezoide sin lados paralelos es un proceso que involucra tres pasos esenciales.");
            Console.WriteLine("Primero, mide la longitud de cada lado del trapezoide. Luego, calcula la altura, que es la distancia entre");
            Console.WriteLine("la base más larga y la base más corta. Finalmente, utiliza la fórmula A = (baseMayor + baseMenor) * altura / 2");
            Console.WriteLine("para encontrar el área del trapezoide en unidades cuadradas. En resumen, midiendo los lados y la altura, y");
            Console.WriteLine("aplicando la fórmula, puedes calcular fácilmente el área de un trapezoide sin lados paralelos.");
        }

        public void PasosPerimetroTrapezoide(double longitudBaseMayor, double longitudBaseMenor, double longitudLado1, double longitudLado2)
        {
            Console.WriteLine("Calcular el perímetro de un trapezoide es un proceso que implica la suma de las longitudes de sus cuatro lados.");
            Console.WriteLine($"Mide la longitud de la base mayor, llamada 'baseMayor', la longitud de la base menor, llamada 'baseMenor',");
            Console.WriteLine($"y las longitudes de los lados no paralelos, llamados 'lado1' y 'lado2'. Luego, utiliza la fórmula");
            Console.WriteLine($"Perímetro = baseMayor + baseMenor + lado1 + lado2 para encontrar el perímetro en la unidad de medida de las longitudes.");
            Console.WriteLine("En resumen, midiendo las bases y los lados no paralelos y aplicando la fórmula, puedes calcular fácilmente el perímetro de un trapezoide.");
        }

    }
}