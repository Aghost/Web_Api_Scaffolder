#!/bin/env sh
# OLD WORDS: PROJECTNAME, CHILDITEM, CHILD
# NEW WORDS
project_name="unnamed"
childitem="unnamed"
item="unnamed"

if [ $# -lt "3" ]; then
    echo "replace names, arg error"
    echo "1: projectname 2:childitem 3:item"
    exit
else
    project_name=$1
    item=$2
    childitem=$3
fi

# Locations
itemModel_dir="$project_name.Core/Models"
dbcontext_dir="$project_name.Data"
controller_dir="$project_name.App/Controllers"
services_dir="$project_name.Business"

replaceFilenames() {
    mv "$itemModel_dir/ITEMModel.cs" "$itemModel_dir/$item.cs"
    mv "$itemModel_dir/CHILDITEMModel.cs" "$itemModel_dir/$childitem.cs"
    mv "$dbcontext_dir/PROJECTNAMEDbContext.cs" "$dbcontext_dir/$project_name""DbContext.cs"
    mv "$controller_dir/Controller.cs" "$controller_dir/$item""Controller.cs"
    mv "$services_dir/Service.cs" "$services_dir/$item""Service.cs"
    mv "$services_dir/IService.cs" "$services_dir/I$item""Services.cs"
}

cd $project_name
replaceFilenames
