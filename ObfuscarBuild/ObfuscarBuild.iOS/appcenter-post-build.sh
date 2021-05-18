if [ "$AGENT_JOBSTATUS" == "Succeeded" ]; then
    cp "$APPCENTER_SOURCE_DIRECTORY/ObfuscarBuild/ObfuscarBuild.iOS/obj/iPhone/AppCenter/obfuscarOutput/Mapping.txt" "$APPCENTER_OUTPUT_DIRECTORY"
fi