src:
	dotnet build

update:
	git pull
	git submodule update --init falcon

submodules-clone:
	git submodule add https://github.com/natarajanganapathi/falcon.git falcon

deinit:
	git submodule deinit -f core
	git rm -f core
	rm -rf .git/modules/core