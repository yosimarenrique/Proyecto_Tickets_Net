Feature: Enviaremail
	Dados una solicitud se envia un correo al area de TI 

@mytag
Scenario: Enviar mensaje
	Given el usuario ingresa a index.xhtml
	When el usuario ingresa el nombre Juan Valdez
	And se ingresa la ubicacion Tech TI 
	And se ingresa el telefono  3005458538
	And se ingresa la descripcion Cambio teclado Prueba
	And presiona el boton enviar correo   
	Then se muestra mensaje de envio

	

