# Project PROJECTNAME

PROJECT_NAME ?= PROJECTNAME

.PHONY: migrations db

migration:
	cd ./PROJECTNAME.Data && dotnet ef --startup-project ../PROJECTNAME.App migrations add $(mname) && cd ..

db:
	cd ./PROJECTNAME.Data && dotnet ef --startup-project ../PROJECTNAME.App/ database update && cd ..

test:
	echo "testing"
