echo "-- 1 --"
find $APPCENTER_SOURCE_DIRECTORY -type d -name 'dSYMs' -print0
iOSSymbolFileName="$(find $APPCENTER_SOURCE_DIRECTORY -type d -name 'dSYMs' -print0)"
echo $iOSSymbolFileName
echo "-- 2 --"
find . -type d -name *.dSYM -print0
iOSSymbolFileName="$(find . -type d -name *.dSYM -print0)"
echo $iOSSymbolFileName