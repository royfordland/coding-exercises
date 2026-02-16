function decodeMessage(key: string, message: string): string {
    const alphabet = "abcdefghijklmnopqrstuvwxyz";
    key = key.replaceAll(" ", "");

    const decryptValues = getDedupedKey(key);

    let decryptedMsg = "";

    for(const character of message)
    {
        if(character == " ")
        {
            decryptedMsg += " ";
        }
        else
        {
            // Get the letter from the map so we can get the decrypted message.
            // Could be 1 line, but it's a bit easier to read when we don't have nested a[b[]]
            const index = decryptValues.indexOf(character);

            decryptedMsg += alphabet[index];
        }
    }

    return decryptedMsg;
};

// In case we get duplicate values in the key we'll only want to pick on the first occurrence of a letter
// Otherwise decrypting will be impossible, or at least very, very hard :P
function getDedupedKey(key: string) 
{
    key = key.replaceAll(" ", "");
    var result = new Array<string>();

    for(const letter of key)
    {
        if(!result.includes(letter))
        {
            result.push(letter);
        }
    }
    
    return result;
}