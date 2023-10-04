cmds = ["d1/","d2/","./","d3/","../","d31/"]


def minOperations(logs) -> int:
    count = 0
    for item in logs:
        match item:
            case "../":
                if (count > 0):
                    count = count - 1
            case "./":
                continue
            case _:
                count = count + 1  
    return count
        
print(minOperations(cmds))


                
        