Commands for building app, building docker image, and running image (and pruning it after run)
> dotnet publish -c Release
> docker build -t counter-image -f Dockerfile.Linux .
> docker run -it --rm counter-image 5
