# make webapi

PROJECT_NAME ?= make_webapi

.PHONY: test clear webapi

webapi:
	./0_main.sh UserRepositoryApi User UserFile

test:
	if [ "test" = "test" ]; then echo "banaan"; fi
