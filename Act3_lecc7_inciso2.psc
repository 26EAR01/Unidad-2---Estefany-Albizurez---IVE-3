Algoritmo Act3_lecc7_inciso2
		Definir ang1, ang2, ang3 Como Entero
		
		Escribir "Ingrese el angulo 1:"
		Leer ang1
		
		Escribir "Ingrese el angulo 2:"
		Leer ang2
		
		Escribir "Ingrese el angulo 3:"
		Leer ang3
		
		Si ang1 = ang2 Y ang2 = ang3 Entonces
			Escribir "Triangulo Equilatero"
			
		SiNo Si ang1 = ang2 O ang1 = ang3 O ang2 = ang3 Entonces
				Escribir "Triangulo Isosceles"
				
			SiNo
				Escribir "Triangulo Escaleno"
				
			FinSi
		FinSi
FinAlgoritmo
