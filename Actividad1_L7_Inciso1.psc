//Promedio de notas
Algoritmo Actividad1_L7_Inciso1
	Definir Materia Como Caracter
	Definir n1,n2, n3, n4, n5, notTotal Como Real
	Escribir "Digite la materia"
	leer materia 
	Escribir  "Digite 5 notas"
	leer n1
	Leer n2
	Leer n3
	Leer n4
	Leer n5
	
	notTotal = (n1+n2+n3+n4+n5)/5
	
	escribir "La materia es: ", materia
	Escribir "La nota total es: ", notTotal
	
	si (n>=70) Entonces
		Escribir "Estudiante aprobado"
	SiNo
		Escribir "Estudiante reprobado"
		
	FinSi
FinAlgoritmo
