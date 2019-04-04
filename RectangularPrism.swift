//
//  RectangularPrism.swift
//
//  Created by Brandon Linton and Noah Castle on 4/3/19.
//  Copyright © 2019 Brandon Linton and Noah Castle. All rights reserved.
//

import Foundation

class RectangularPrism{
    
    private var length, width, height: Double
    
    init(length: Double, width: Double, height: Double){
        self.length = length
        self.width = width
        self.height = height
    }
    
    public func calculateSurfaceArea() -> Double{
        var length_times_width, length_times_height, width_times_height: Double
        length_times_width = (length * width)    //Product of length and width
        length_times_height = (length * height)  //Product of length and height
        width_times_height = (width * height)    //Product of width and height
        return (2 * ((length_times_width) + (length_times_height) + (width_times_height))) //Calculate surface area
    }
    
    public func calculateVolume() -> Double{
        return ((length) * (width) * (height)) //Calculate volume
    }
    
    public func getLength() -> Double{
        return length
    }
    
    public func getWidth() -> Double{
        return width
    }
    
    public func getHeight() -> Double{
        return height
    }
    
}
