# Project Variables

PROJECT_NAME ?= personal-library

.PHONY: migrations db

migrations:
	cd ./PersonalLibrary.Data && dotnet ef --startup-project ../PersonalLibrary.Web/ migrations add $(mname) && cd ..

db:
	cd ./PersonalLibrary.Data && dotnet ef --startup-project ../PersonalLibrary.Web/ database update && cd ..

hello:
	echo 'Hello!'
