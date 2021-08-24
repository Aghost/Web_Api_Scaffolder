#!/bin/sh
echo
echo ">>>>>> birds: "
echo
curl localhost:5000/api/bird/duck
echo
curl localhost:5000/api/bird/goose
echo
curl localhost:5000/api/bird/chicken
echo

echo
echo ">>>>>> add/minus pi: "
echo
curl localhost:5000/api/pi/add/123
echo
curl localhost:5000/api/pi/minus/321
echo

echo
echo ">>>>>> add/movies all: "
echo
curl localhost:5000/api/movies/
echo

echo ">>>>>> add/movies 1: "
curl localhost:5000/api/movies/1
echo
