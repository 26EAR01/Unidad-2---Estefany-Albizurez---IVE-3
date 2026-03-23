//Problema : un progranma que muestre un mensaje de voz 
//crear menu - 1Recepcion
//2- Vigilancia
//3 - Mantenimiento
//4- salir o error 
Algoritmo MensajeVoz
	escribir "====MENSAJE DE VOZ===="
	//VARIABLES
	Definir opc Como Entero
	
	//Menu
	Escribir "Menu principal"
	escribir "1- Recepcion"
	Escribir  "2- Vigilancia"
	Escribir "3- Mantenimietno"
	Escribir "4- Salir"
	Escribir sin saltar "Digite un aaccion: "
	leer opc
	
	//Condiciones
	si (opc == 1) Entonces 
		Escribir "Bienvenido al departamento de recepcion"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 segundos 
	FinSi
	si (opc == 2) Entonces 
		Escribir "Bienvenido al departamento de vigilancia"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 segundos 
	FinSi
	si (opc == 3) Entonces 
		Escribir "Bienvenido al departamento de Mantenimiento"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 segundos 
	FinSi
	si (opc <> 1 y opc<>2 y opc<>3) Entonces //anotacion, usamos ope.relacion y ope.codigo
		Escribir "Saliendo del sistema"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 segundos 
	FinSi
	
FinAlgoritmo
