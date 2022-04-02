# this outputs a 16bit Png image

from PIL import Image
import numpy as np

testImage = np.zeros((512, 512), np.uint16)
def Main():
    testImage.fill(65535) # range 0 -> 65535
    array_buffer = testImage.tobytes()
    img = Image.new("I", testImage.T.shape)
    img.frombytes(array_buffer, 'raw', "I;16")
    img.save("HeightMapOutput.png")
# ---------------------------------------------------------------------------------------------------------------------------------------
