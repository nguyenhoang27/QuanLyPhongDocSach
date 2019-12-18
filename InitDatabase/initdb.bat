InitDatabase.exe -o "thuvien.db" -e secret -d docgia.json -s sach.json -q quydinh.json -p quyen.json --yes
@echo off
(
echo ^<config^>
echo 	^<database^>thuvien.db^</database^>
echo 	^<secret^>secret^</secret^>
echo ^</config^>
) > config.xml
exit