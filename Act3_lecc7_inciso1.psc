Algoritmo Act3_lecc7_inciso1
		
		Definir dia, mes Como Entero
		
		Escribir "Ingrese el dia:"
		Leer dia
		
		Escribir "Ingrese el mes (1-12):"
		Leer mes
		
		Si (mes = 3 Y dia >= 21) O (mes = 4) O (mes = 5) O (mes = 6 Y dia <= 20) Entonces
			Escribir "Primavera"
			
		SiNo Si (mes = 6 Y dia >= 21) O (mes = 7) O (mes = 8) O (mes = 9 Y dia <= 22) Entonces
				Escribir "Verano"
				
			SiNo Si (mes = 9 Y dia >= 23) O (mes = 10) O (mes = 11) O (mes = 12 Y dia <= 20) Entonces
					Escribir "Otoño"
					
				SiNo
					Escribir "Invierno"
					
				FinSi
				
			FinSi
		FinSi
FinAlgoritmo
