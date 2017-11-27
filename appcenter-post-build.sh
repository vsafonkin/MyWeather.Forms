find . -name '*.Tests.nUnit.dll' -print0 | /usr/bin/xargs -0 -n1 nunit-console
find . -name 'TestResult.xml' -print0 | /usr/bin/xargs -0 -n1 cat