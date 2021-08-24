#!/bin/env sh
#OLD WORDS: PROJECTNAME, CHILDITEM, CHILD
#NEW WORDS
project_name="unnamed"
childitem="unnamed"
item="unnamed"

if [ $# -lt "3" ]; then
    echo "replace names, arg error"
    echo "1: projectname 2:childitem 3:item"
    exit
else
    echo "Replacing names..."
    project_name=$1
    item=$2
    childitem=$3
fi

## APP, startup
startup="$project_name.App/Startup.cs"
program="$project_name.App/Program.cs"

## CORE, coremodels
coremodels="$project_name.Core/Models/*"

# DBCONTEXT
dbcontext="$project_name.Data/PROJECTNAMEDbContext.cs"

# BUSINESS / SERVICES
service="$project_name.Business/*.cs"

# CONTROLLERS
controller="$project_name.App/Controllers/*.cs"

# APPSETTINGS
appsettings="$project_name.App/appsettings.json"
appsettings_dev="$project_name.App/appsettings.Development.json"

# POPULATE DB SCRIPT
db_script="populate_db.sh"

replaceWords() {
    old_word='PROJECTNAME'
    new_word=$project_name
    for infile in $coremodels $dbcontext $controller $service $iservice $appsettings $appsettings_dev $startup $program 'Makefile'; do
        sed -i s/$old_word/$new_word/g $infile
    done

    old_word='CHILDITEM'
    new_word=$childitem
    for infile in $coremodels $dbcontext $controller $service $iservice $startup $db_script; do
        sed -i s/$old_word/$new_word/g $infile
    done

    old_word='ITEM'
    new_word=$item
    for infile in $coremodels $dbcontext $controller $service $iservice $startup $db_script; do
        sed -i s/$old_word/$new_word/g $infile
    done

    old_word='iTEM'
    #echo "${input,}"
    new_word=`echo "$item" | tr '[A-Z]' '[a-z]'`
    for infile in $coremodels $dbcontext $controller $service $iservice; do
        sed -i s/$old_word/$new_word/g $infile
    done
}

#cp -r templates/* "$project_name/"
cd $project_name

replaceWords
