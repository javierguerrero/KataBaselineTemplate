
### Notas
1. Descargar template 
2. Crear contenedor para BD para trabajar localmente (ver comando de creación de contenedor con volumen)
3. Ejecutar API
4. Happy coding!



### Docker
Listar las imágenes instaladas en el equipo
```
docker image ls
```

Creación contenedor con volumen (en Windows)
```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=.123Pass456." -p 1433:1433 --name kata.db -v /c/data/docker/database:/var/opt/mssql/data -d mcr.microsoft.com/mssql/server:2022-latest
```

Despliegue de contenedores en Docker
```
docker-compose -f docker-compose.yml up -d
```

### Migrations commnands in EF Core

**Adding a migration**

```
PM> Add-Migration
```

- Startup project: BirthdayBot
- Default project in PMC: Infrastructure

**Create or Update the Database**

```
PM> Update-Database
```

**Remove a migration**

```
PM> Remove-Migration
```

**Deshacer último Update-Database**

```
PM> Update-Database [Migration_Name]
```