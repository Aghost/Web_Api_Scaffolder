# Project UserRepositoryApi

PROJECT_NAME ?= UserRepositoryApi

.PHONY: migrations db

migration:
	cd ./UserRepositoryApi.Data && dotnet ef --startup-project ../UserRepositoryApi.App migrations add $(mname) && cd ..

db:
	cd ./UserRepositoryApi.Data && dotnet ef --startup-project ../UserRepositoryApi.App/ database update && cd ..

test:
	echo "testing"
