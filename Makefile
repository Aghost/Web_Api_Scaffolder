# make webapp

PROJECT_NAME ?= make_webapp

.PHONY: test clear webapp

webapp:
	./0_main.sh DependencyInjectionProject CustomItem CustomChildItem

test:
	if [ "test" = "test" ]; then echo "banaan"; fi
