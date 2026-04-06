Algoritmo Act3_Lecc20_Inciso1
		Definir dia Como Entero
		
		Escribir "Ingrese un numero del 1 al 7:"
		Leer dia
		
		Si dia >= 1 Y dia <= 5 Entonces
			Escribir "Es un dia entre semana"
			
		SiNo Si dia = 6 O dia = 7 Entonces
				Escribir "Es fin de semana"
				
			SiNo
				Escribir "Numero invalido"
				
			FinSi
		FinSi
FinAlgoritmo
