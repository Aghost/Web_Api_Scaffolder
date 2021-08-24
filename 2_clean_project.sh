#!/bin/env sh
project_name=$1

cd $project_name
rm "$project_name.App/WeatherForecast.cs"
rm "$project_name.App/Controllers/WeatherForecastController.cs"
rm "$project_name.Data/Class1.cs"
rm "$project_name.Business/Class1.cs"
rm "$project_name.Core/Class1.cs"
