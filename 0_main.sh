#!/bin/sh

project_name="unnamed"
child_item="unnamed"
item="unnamed"

if [ $# -lt "3" ]; then
    echo -n "what is the project name? "
    read project_name
    echo -n "what is the model item name? "
    read item
    echo -n "what is the model child item name? "
    read child_item
else
    project_name=$1
    item=$2
    child_item=$3
fi

./1_make_webapp.sh $project_name
./2_clean_project.sh $project_name
./3_copy_template.sh $project_name
./4_replace_names.sh $project_name $item $child_item
./5_rename_filenames.sh $project_name $item $child_item
./6_sql_script.sh
