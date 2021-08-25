#!/bin/sh

project_name="unnamed_project"

if [ $# = "1" ]; then
    project_name=$1
else
    echo -n "what is the project name? "
    read project_name
fi

mkdir $project_name
cd $project_name

dotnet new sln
dotnet new webapi -o $project_name.App
dotnet new classlib -o $project_name.Core
dotnet new classlib -o $project_name.Data
dotnet new classlib -o $project_name.Business
dotnet new xunit -o $project_name.Test

dotnet sln add $project_name.App
dotnet sln add $project_name.Core
dotnet sln add $project_name.Data
dotnet sln add $project_name.Business
dotnet sln add $project_name.Test

# APP
cd $project_name.App
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
#dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Newtonsoft.Json

dotnet add reference ../$project_name.Business
dotnet add reference ../$project_name.Core
dotnet add reference ../$project_name.Data

# CORE
cd ../$project_name.Core

# DATA
cd ../$project_name.Data
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add reference ../$project_name.Core

# BUSINESS
cd ../$project_name.Business
dotnet add reference ../$project_name.Core
dotnet add reference ../$project_name.Data
