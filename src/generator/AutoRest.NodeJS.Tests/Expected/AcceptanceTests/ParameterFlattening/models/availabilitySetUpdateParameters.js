/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the AvailabilitySetUpdateParameters class.
 * @constructor
 * @member {object} tags A set of tags. A description about the set of tags.
 * 
 */
function AvailabilitySetUpdateParameters() {
}

/**
 * Defines the metadata of AvailabilitySetUpdateParameters
 *
 * @returns {object} metadata of AvailabilitySetUpdateParameters
 *
 */
AvailabilitySetUpdateParameters.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'AvailabilitySetUpdateParameters',
    type: {
      name: 'Composite',
      className: 'AvailabilitySetUpdateParameters',
      modelProperties: {
        tags: {
          required: true,
          serializedName: 'tags',
          type: {
            name: 'Dictionary',
            value: {
                required: false,
                serializedName: 'StringElementType',
                type: {
                  name: 'String'
                }
            }
          }
        }
      }
    }
  };
};

module.exports = AvailabilitySetUpdateParameters;
