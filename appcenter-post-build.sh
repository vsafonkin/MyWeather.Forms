echo "-= Build nUnit test projects: =-"
find . -regex '.*\.Tests\.nUnit\.csproj' -exec msbuild {} \;
echo
echo "-= Found projects to run nUnit tests: =-"
find . -regex '.*bin.*\.Tests\.nUnit\.dll' -exec echo {} \;
echo
echo "-= Running nUnit tests: =-"
find . -regex '.*bin.*\.Tests\.nUnit\.dll' -exec nunit-console {} \;
echo
echo "-= nUnit test result: =-"
find . -name 'TestResult.xml' -exec cat {} \;