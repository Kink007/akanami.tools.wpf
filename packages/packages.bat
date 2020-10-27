IF EXIST "$(TargetDir)lib" RMDIR "$(TargetDir)lib" /Q
IF NOT EXIST "$(TargetDir)lib" MD "$(TargetDir)lib"
XCOPY "$(TargetDir)*.*" "$(TargetDir)lib"
DEL "$(TargetDir)*.*" /Q
XCOPY "$(TargetDir)lib\Akanami.FastDev.Client*.*" "$(TargetDir)"
DEL "$(TargetDir)lib\Akanami.FastDev.Client*.*" /Q
IF EXIST "$(TargetDir)modules\netcoreapp3.1" XCOPY "$(TargetDir)modules\netcoreapp3.1\*.*" "$(TargetDir)modules\" /Q /s /y /e 
IF EXIST "$(TargetDir)modules\netcoreapp3.1" RMDIR "$(TargetDir)modules\netcoreapp3.1" /Q /S