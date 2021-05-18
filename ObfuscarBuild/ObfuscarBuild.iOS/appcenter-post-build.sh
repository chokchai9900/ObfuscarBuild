if [ "$AGENT_JOBSTATUS" == "Succeeded" ]; then
    echo This is some text > $APPCENTER_OUTPUT_DIRECTORY/myfile.txt
fi