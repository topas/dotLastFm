$framework = '4.0'

properties { 
    $build_dir = Split-Path $psake.build_script_file
    $build_output = "$build_dir\build\"
    $release_output = "$build_dir\release\"
    $code_dir = "$build_dir\src"
    $xunit_dir = "$build_dir\lib\xunit"
}

task default -depends Release

task Release -depends Test {
    Write-Host "Creating release..." -ForegroundColor Green

    cp $build_output\dotLastFm.dll $release_output
    cp $build_output\RestSharp.dll $release_output
}

task Test -depends Compile, Clean { 
    Write-Host "Testing..." -ForegroundColor Green
    
    $old = pwd
    cd $xunit_dir
    cp $xunit_dir\Xunit.dll $build_output
    Exec { &"$xunit_dir\xunit.console.clr4.exe" "$build_output\dotLastFm.IntegrationTests.dll" }
    cd $old	
}

task Compile -depends Clean { 
    Write-Host "Compiling..." -ForegroundColor Green
    
    Exec { msbuild "$code_dir\dotLastFm.sln" /t:Build /p:Configuration=Release /v:quiet /p:OutDir=$build_output } 
}

task Clean { 
    Write-Host "Cleaning..." -ForegroundColor Green
  
    if (Test-Path $build_output) 
    {
        rd $build_output -rec -force | out-null
    }
    mkdir $build_output | out-null
    
    if (Test-Path $release_output) 
    {
        rd $release_output -rec -force | out-null
    }
    mkdir $release_output | out-null
    
    Exec { msbuild "$code_dir\dotLastFm.sln" /t:Clean /p:Configuration=Release /v:quiet }
}