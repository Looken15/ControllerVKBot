chcp 65001
ssh root@82.97.243.226 "rm -r //mypath"
scp -r C:\Users\Артём\Desktop\ControllerBot root@82.97.243.226:/mypath
ssh root@82.97.243.226 "docker stop bot"
ssh root@82.97.243.226 "docker rm bot"
ssh root@82.97.243.226 "docker rmi bot"
ssh root@82.97.243.226 "docker buildx build --no-cache -f //mypath/ControllerBot/Dockerfile -t bot //mypath/."
ssh root@82.97.243.226 "docker run --name bot -p 80:80 bot"
pause