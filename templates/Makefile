# Project PROJECTNAME

PROJECT_NAME ?= PROJECTNAME

.PHONY: migrations db

migrations:
	cd ./PROJECTNAME.Data && dotnet ef --startup-project ../PROJECTNAME.App migrations add $(mname) && cd ..

db:
	cd ./PROJECTNAME.Data && dotnet ef --startup-project ../PROJECTNAME.App/ database update && cd ..

test:
	echo "testing"
