# Etapa base: imagen para ejecutar la app
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Etapa build: imagen para compilar la app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app/out

# Etapa final: mover archivos compilados
FROM base AS final
WORKDIR /app
COPY --from=build /app/out .

# Reemplaza TransactionalPrototype.dll por el nombre correcto si es distinto
ENTRYPOINT ["dotnet", "WebApplication1.dll"]

