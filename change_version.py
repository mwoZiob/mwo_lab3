file = open('version.txt', 'r')
actual_version = int(file.read())
file.close()
new_version = actual_version + 1
file = open('version.txt', 'w')
file.write(str(new_version))
file.close()
