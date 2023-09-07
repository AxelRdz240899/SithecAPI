# SithecAPI

Prueba técnica .Net Core 6.0 para la empresa Sithec.

Instrucciones para crear la instancia de servidor de SQL y ejecutar las migraciones: 
  
  - Es necesario crear una instancia de SQL Server con el nombre que tiene en la conexión de datos en el archivo appsetings.json o cambiar dicha conexión. Para crear la instancia se utiliza el sig comando en la   terminal de windows "sqllocaldb create HumanDBInstance"
  
  - Para correr la migración de la BD recomiendo hacerlo desde la terminal de paquetes NuGet en Visual Studio, ya que se tiene que seleccionar el proyecto en el cual se encuentran las migraciones, como el proyecto lo realicé bajo una arquitectura de capas es necesario setear en la terminal el proyecto de "Infrastructure", como se ve en la imagen: 
  
  ![image](https://github.com/AxelRdz240899/SithecAPI/assets/38929908/4c752a8b-6b90-4946-a0aa-a40a8d86a777)

Despues ejecutar el comando "Update-Database" para crear la base de datos que se utiliza en la api.
