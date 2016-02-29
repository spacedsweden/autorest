/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.validation.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The product documentation.
 */
public class Product {
    /**
     * Non required array of unique items from 0 to 6 elements.
     */
    @JsonProperty(value = "display_names")
    private List<String> displayNames;

    /**
     * Non required int betwen 0 and 100 exclusive.
     */
    private Integer capacity;

    /**
     * Image URL representing the product.
     */
    private String image;

    /**
     * The child property.
     */
    private ChildProduct child;

    /**
     * The constChild property.
     */
    private ConstantProduct constChild;

    /**
     * Constant int.
     */
    @JsonProperty(required = true)
    private int constInt;

    /**
     * Constant string.
     */
    @JsonProperty(required = true)
    private String constString;

    /**
     * Creates an instance of Product class.
     */
    public Product() {
        constChild = new ConstantProduct();
        constInt = 0;
        constString = "constant";
    }

    /**
     * Get the displayNames value.
     *
     * @return the displayNames value
     */
    public List<String> getDisplayNames() {
        return this.displayNames;
    }

    /**
     * Set the displayNames value.
     *
     * @param displayNames the displayNames value to set
     */
    public void setDisplayNames(List<String> displayNames) {
        this.displayNames = displayNames;
    }

    /**
     * Get the capacity value.
     *
     * @return the capacity value
     */
    public Integer getCapacity() {
        return this.capacity;
    }

    /**
     * Set the capacity value.
     *
     * @param capacity the capacity value to set
     */
    public void setCapacity(Integer capacity) {
        this.capacity = capacity;
    }

    /**
     * Get the image value.
     *
     * @return the image value
     */
    public String getImage() {
        return this.image;
    }

    /**
     * Set the image value.
     *
     * @param image the image value to set
     */
    public void setImage(String image) {
        this.image = image;
    }

    /**
     * Get the child value.
     *
     * @return the child value
     */
    public ChildProduct getChild() {
        return this.child;
    }

    /**
     * Set the child value.
     *
     * @param child the child value to set
     */
    public void setChild(ChildProduct child) {
        this.child = child;
    }

    /**
     * Get the constChild value.
     *
     * @return the constChild value
     */
    public ConstantProduct getConstChild() {
        return this.constChild;
    }

    /**
     * Set the constChild value.
     *
     * @param constChild the constChild value to set
     */
    public void setConstChild(ConstantProduct constChild) {
        this.constChild = constChild;
    }

    /**
     * Get the constInt value.
     *
     * @return the constInt value
     */
    public int getConstInt() {
        return this.constInt;
    }

    /**
     * Set the constInt value.
     *
     * @param constInt the constInt value to set
     */
    public void setConstInt(int constInt) {
        this.constInt = constInt;
    }

    /**
     * Get the constString value.
     *
     * @return the constString value
     */
    public String getConstString() {
        return this.constString;
    }

    /**
     * Set the constString value.
     *
     * @param constString the constString value to set
     */
    public void setConstString(String constString) {
        this.constString = constString;
    }

}
