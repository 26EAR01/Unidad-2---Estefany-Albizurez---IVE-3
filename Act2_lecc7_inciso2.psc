Algoritmo Act2_lecc7_inciso2
	
	Definir nota Como Entero
	
	Escribir "Ingrese la calificacion:"
	Leer nota
	
	Si nota < 60 Entonces
		Escribir "Deficiente"
		
	SiNo 
		Si nota < 70 Entonces
			Escribir "Regular"
			
		SiNo Si nota < 80 Entonces
				Escribir "Bien"
				
			SiNo Si nota < 90 Entonces
					Escribir "Muy Bien"
					
				SiNo
					Escribir "Excelente"
				FinSi
			FinSi
		FinSi
	FinSi
				
FinAlgoritmo
