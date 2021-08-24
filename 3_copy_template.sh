#!/bin/env sh
project_name=$1

## APP
cp -r templates/App/* $project_name/$project_name.App/
cp -r templates/App/Controllers/* $project_name/$project_name.App/Controllers/

## BUSINESS
cp -r templates/Business/* $project_name/$project_name.Business/

## CORE
cp -r templates/Core/* $project_name/$project_name.Core/

## DATA
cp -r templates/Data/* $project_name/$project_name.Data/

## TEST
cp -r templates/Test/* $project_name/$project_name.Test/

## MAKEFILE
cp -r templates/Makefile $project_name/

## POPULATE_DB_SCRIPT
cp templates/populate_db.sh $project_name/
