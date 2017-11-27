echo "-= Found projects to run nUnit tests: =-"
find . -regex '.*bin.*\.Tests\.nUnit\.dll' -exec echo {} \;
echo
echo "-= Running nUnit tests: =-"
find . -regex '.*bin.*\.Tests\.nUnit\.dll' -exec nunit-console {} \;
echo
echo "-= nUnit test result: =-"
find . -name 'TestResult.xml' -exec cat {} \;