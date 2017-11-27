find . -name '*.Tests.nUnit.dll' -exec nunit-console {} \;
find . -name 'TestResult.xml' -exec cat {} \;