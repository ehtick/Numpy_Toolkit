/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Numpy.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Numpy.UnitTest
{
    [TestClass]
    public class NumPy_ioTest : BaseTestCase
    {
        
        [TestMethod]
        public void loadTest()
        {
            // Store data to disk, and load it again:
            
            // >>> np.save('/tmp/123', np.array([[1, 2, 3], [4, 5, 6]]))
            // >>> np.load('/tmp/123.npy')
            // array([[1, 2, 3],
            //        [4, 5, 6]])
            // 
            
            #if TODO
            var given=  np.save('/tmp/123', np.array({{1, 2, 3}, {4, 5, 6}}));
             given=  np.load('/tmp/123.npy');
            var expected=
                "array([[1, 2, 3],\n" +
                "       [4, 5, 6]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Store compressed data to disk, and load it again:
            
            // >>> a=np.array([[1, 2, 3], [4, 5, 6]])
            // >>> b=np.array([1, 2])
            // >>> np.savez('/tmp/123.npz', a=a, b=b)
            // >>> data = np.load('/tmp/123.npz')
            // >>> data['a']
            // array([[1, 2, 3],
            //        [4, 5, 6]])
            // >>> data['b']
            // array([1, 2])
            // >>> data.close()
            // 
            
            #if TODO
             given=  a=np.array({{1, 2, 3}, {4, 5, 6}});
             given=  b=np.array({1, 2});
             given=  np.savez('/tmp/123.npz', a=a, b=b);
             given=  data = np.load('/tmp/123.npz');
             given=  data['a'];
             expected=
                "array([[1, 2, 3],\n" +
                "       [4, 5, 6]])";
            Assert.AreEqual(expected, given.repr);
             given=  data['b'];
             expected=
                "array([1, 2])";
            Assert.AreEqual(expected, given.repr);
             given=  data.close();
            #endif
            // Mem-map the stored array, and then access the second row
            // directly from disk:
            
            // >>> X = np.load('/tmp/123.npy', mmap_mode='r')
            // >>> X[1, :]
            // memmap([4, 5, 6])
            // 
            
            #if TODO
             given=  X = np.load('/tmp/123.npy', mmap_mode='r');
             given=  X[1, :];
             expected=
                "memmap([4, 5, 6])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void saveTest()
        {
            // >>> from tempfile import TemporaryFile
            // >>> outfile = TemporaryFile()
            // 
            
            #if TODO
            var given=  from tempfile import TemporaryFile;
             given=  outfile = TemporaryFile();
            #endif
            // >>> x = np.arange(10)
            // >>> np.save(outfile, x)
            // 
            
            #if TODO
             given=  x = np.arange(10);
             given=  np.save(outfile, x);
            #endif
            // >>> outfile.seek(0) # Only needed here to simulate closing & reopening file
            // >>> np.load(outfile)
            // array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])
            // 
            
            #if TODO
             given=  outfile.seek(0) # Only needed here to simulate closing & reopening file;
             given=  np.load(outfile);
            var expected=
                "array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void savezTest()
        {
            // >>> from tempfile import TemporaryFile
            // >>> outfile = TemporaryFile()
            // >>> x = np.arange(10)
            // >>> y = np.sin(x)
            // 
            
            #if TODO
            var given=  from tempfile import TemporaryFile;
             given=  outfile = TemporaryFile();
             given=  x = np.arange(10);
             given=  y = np.sin(x);
            #endif
            // Using savez with *args, the arrays are saved with default names.
            
            // >>> np.savez(outfile, x, y)
            // >>> outfile.seek(0) # Only needed here to simulate closing & reopening file
            // >>> npzfile = np.load(outfile)
            // >>> npzfile.files
            // ['arr_1', 'arr_0']
            // >>> npzfile['arr_0']
            // array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])
            // 
            
            #if TODO
             given=  np.savez(outfile, x, y);
             given=  outfile.seek(0) # Only needed here to simulate closing & reopening file;
             given=  npzfile = np.load(outfile);
             given=  npzfile.files;
            var expected=
                "['arr_1', 'arr_0']";
            Assert.AreEqual(expected, given.repr);
             given=  npzfile['arr_0'];
             expected=
                "array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using savez with **kwds, the arrays are saved with the keyword names.
            
            // >>> outfile = TemporaryFile()
            // >>> np.savez(outfile, x=x, y=y)
            // >>> outfile.seek(0)
            // >>> npzfile = np.load(outfile)
            // >>> npzfile.files
            // ['y', 'x']
            // >>> npzfile['x']
            // array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])
            // 
            
            #if TODO
             given=  outfile = TemporaryFile();
             given=  np.savez(outfile, x=x, y=y);
             given=  outfile.seek(0);
             given=  npzfile = np.load(outfile);
             given=  npzfile.files;
             expected=
                "['y', 'x']";
            Assert.AreEqual(expected, given.repr);
             given=  npzfile['x'];
             expected=
                "array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void savez_compressedTest()
        {
            // >>> test_array = np.random.rand(3, 2)
            // >>> test_vector = np.random.rand(4)
            // >>> np.savez_compressed('/tmp/123', a=test_array, b=test_vector)
            // >>> loaded = np.load('/tmp/123.npz')
            // >>> print(np.array_equal(test_array, loaded['a']))
            // True
            // >>> print(np.array_equal(test_vector, loaded['b']))
            // True
            // 
            
            #if TODO
            var given=  test_array = np.random.rand(3, 2);
             given=  test_vector = np.random.rand(4);
             given=  np.savez_compressed('/tmp/123', a=test_array, b=test_vector);
             given=  loaded = np.load('/tmp/123.npz');
             given=  print(np.array_equal(test_array, loaded{'a'}));
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  print(np.array_equal(test_vector, loaded{'b'}));
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void savetxtTest()
        {
            // >>> x = y = z = np.arange(0.0,5.0,1.0)
            // >>> np.savetxt('test.out', x, delimiter=',')   # X is an array
            // >>> np.savetxt('test.out', (x,y,z))   # x,y,z equal sized 1D arrays
            // >>> np.savetxt('test.out', x, fmt='%1.4e')   # use exponential notation
            // 
            
            #if TODO
            var given=  x = y = z = np.arange(0.0,5.0,1.0);
             given=  np.savetxt('test.out', x, delimiter=',')   # X is an array;
             given=  np.savetxt('test.out', (x,y,z))   # x,y,z equal sized 1D arrays;
             given=  np.savetxt('test.out', x, fmt='%1.4e')   # use exponential notation;
            #endif
        }
        
        
        [TestMethod]
        public void genfromtxtTest()
        {
            // >>> from io import StringIO
            // >>> import numpy as np
            // 
            
            #if TODO
            var given=  from io import StringIO;
             given=  import numpy as np;
            #endif
            // Comma delimited file with mixed dtype
            
            // >>> s = StringIO(u"1,1.3,abcde")
            // >>> data = np.genfromtxt(s, dtype=[('myint','i8'),('myfloat','f8'),
            // ... ('mystring','S5')], delimiter=",")
            // >>> data
            // array((1, 1.3, 'abcde'),
            //       dtype=[('myint', '<i8'), ('myfloat', '<f8'), ('mystring', '|S5')])
            // 
            
            #if TODO
             given=  s = StringIO(u"1,1.3,abcde");
             given=  data = np.genfromtxt(s, dtype={('myint','i8'),('myfloat','f8'),;
            var expected=
                "... ('mystring','S5')], delimiter=",")";
            Assert.AreEqual(expected, given.repr);
             given=  data;
             expected=
                "array((1, 1.3, 'abcde'),\n" +
                "      dtype=[('myint', '<i8'), ('myfloat', '<f8'), ('mystring', '|S5')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using dtype = None
            
            // >>> s.seek(0) # needed for StringIO example only
            // >>> data = np.genfromtxt(s, dtype=None,
            // ... names = ['myint','myfloat','mystring'], delimiter=",")
            // >>> data
            // array((1, 1.3, 'abcde'),
            //       dtype=[('myint', '<i8'), ('myfloat', '<f8'), ('mystring', '|S5')])
            // 
            
            #if TODO
             given=  s.seek(0) # needed for StringIO example only;
             given=  data = np.genfromtxt(s, dtype=None,;
             expected=
                "... names = ['myint','myfloat','mystring'], delimiter=",")";
            Assert.AreEqual(expected, given.repr);
             given=  data;
             expected=
                "array((1, 1.3, 'abcde'),\n" +
                "      dtype=[('myint', '<i8'), ('myfloat', '<f8'), ('mystring', '|S5')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Specifying dtype and names
            
            // >>> s.seek(0)
            // >>> data = np.genfromtxt(s, dtype="i8,f8,S5",
            // ... names=['myint','myfloat','mystring'], delimiter=",")
            // >>> data
            // array((1, 1.3, 'abcde'),
            //       dtype=[('myint', '<i8'), ('myfloat', '<f8'), ('mystring', '|S5')])
            // 
            
            #if TODO
             given=  s.seek(0);
             given=  data = np.genfromtxt(s, dtype="i8,f8,S5",;
             expected=
                "... names=['myint','myfloat','mystring'], delimiter=",")";
            Assert.AreEqual(expected, given.repr);
             given=  data;
             expected=
                "array((1, 1.3, 'abcde'),\n" +
                "      dtype=[('myint', '<i8'), ('myfloat', '<f8'), ('mystring', '|S5')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // An example with fixed-width columns
            
            // >>> s = StringIO(u"11.3abcde")
            // >>> data = np.genfromtxt(s, dtype=None, names=['intvar','fltvar','strvar'],
            // ...     delimiter=[1,3,5])
            // >>> data
            // array((1, 1.3, 'abcde'),
            //       dtype=[('intvar', '<i8'), ('fltvar', '<f8'), ('strvar', '|S5')])
            // 
            
            #if TODO
             given=  s = StringIO(u"11.3abcde");
             given=  data = np.genfromtxt(s, dtype=None, names={'intvar','fltvar','strvar'},;
             expected=
                "...     delimiter=[1,3,5])";
            Assert.AreEqual(expected, given.repr);
             given=  data;
             expected=
                "array((1, 1.3, 'abcde'),\n" +
                "      dtype=[('intvar', '<i8'), ('fltvar', '<f8'), ('strvar', '|S5')])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void fromregexTest()
        {
            // >>> f = open('test.dat', 'w')
            // >>> f.write("1312 foo\n1534  bar\n444   qux")
            // >>> f.close()
            // 
            
            #if TODO
            var given=  f = open('test.dat', 'w');
             given=  f.write("1312 foo\n1534  bar\n444   qux");
             given=  f.close();
            #endif
            // >>> regexp = r"(\d+)\s+(...)"  # match [digits, whitespace, anything]
            // >>> output = np.fromregex('test.dat', regexp,
            // ...                       [('num', np.int64), ('key', 'S3')])
            // >>> output
            // array([(1312L, 'foo'), (1534L, 'bar'), (444L, 'qux')],
            //       dtype=[('num', '<i8'), ('key', '|S3')])
            // >>> output['num']
            // array([1312, 1534,  444], dtype=int64)
            // 
            
            #if TODO
             given=  regexp = r"(\d+)\s+(...)"  # match [digits, whitespace, anything];
             given=  output = np.fromregex('test.dat', regexp,;
            var expected=
                "...                       [('num', np.int64), ('key', 'S3')])";
            Assert.AreEqual(expected, given.repr);
             given=  output;
             expected=
                "array([(1312L, 'foo'), (1534L, 'bar'), (444L, 'qux')],\n" +
                "      dtype=[('num', '<i8'), ('key', '|S3')])";
            Assert.AreEqual(expected, given.repr);
             given=  output['num'];
             expected=
                "array([1312, 1534,  444], dtype=int64)";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void tolistTest()
        {
            // >>> a = np.array([1, 2])
            // >>> a.tolist()
            // [1, 2]
            // >>> a = np.array([[1, 2], [3, 4]])
            // >>> list(a)
            // [array([1, 2]), array([3, 4])]
            // >>> a.tolist()
            // [[1, 2], [3, 4]]
            // 
            
            #if TODO
            var given=  a = np.array({1, 2});
             given=  a.tolist();
            var expected=
                "[1, 2]";
            Assert.AreEqual(expected, given.repr);
             given=  a = np.array({{1, 2}, {3, 4}});
             given=  list(a);
             expected=
                "[array([1, 2]), array([3, 4])]";
            Assert.AreEqual(expected, given.repr);
             given=  a.tolist();
             expected=
                "[[1, 2], [3, 4]]";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void array2stringTest()
        {
            // >>> x = np.array([1e-16,1,2,3])
            // >>> print(np.array2string(x, precision=2, separator=',',
            // ...                       suppress_small=True))
            // [ 0., 1., 2., 3.]
            // 
            
            #if TODO
            var given=  x = np.array({1e-16,1,2,3});
             given=  print(np.array2string(x, precision=2, separator=',',;
            var expected=
                "...                       suppress_small=True))\n" +
                "[ 0., 1., 2., 3.]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x  = np.arange(3.)
            // >>> np.array2string(x, formatter={'float_kind':lambda x: "%.2f" % x})
            // '[0.00 1.00 2.00]'
            // 
            
            #if TODO
             given=  x  = np.arange(3.);
             given=  np.array2string(x, formatter={'float_kind':lambda x: "%.2f" % x});
             expected=
                "'[0.00 1.00 2.00]'";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x  = np.arange(3)
            // >>> np.array2string(x, formatter={'int':lambda x: hex(x)})
            // '[0x0L 0x1L 0x2L]'
            // 
            
            #if TODO
             given=  x  = np.arange(3);
             given=  np.array2string(x, formatter={'int':lambda x: hex(x)});
             expected=
                "'[0x0L 0x1L 0x2L]'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void array_reprTest()
        {
            // >>> np.array_repr(np.array([1,2]))
            // 'array([1, 2])'
            // >>> np.array_repr(np.ma.array([0.]))
            // 'MaskedArray([ 0.])'
            // >>> np.array_repr(np.array([], np.int32))
            // 'array([], dtype=int32)'
            // 
            
            #if TODO
            var given=  np.array_repr(np.array({1,2}));
            var expected=
                "'array([1, 2])'";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_repr(np.ma.array({0.}));
             expected=
                "'MaskedArray([ 0.])'";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_repr(np.array({}, np.int32));
             expected=
                "'array([], dtype=int32)'";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x = np.array([1e-6, 4e-7, 2, 3])
            // >>> np.array_repr(x, precision=6, suppress_small=True)
            // 'array([ 0.000001,  0.      ,  2.      ,  3.      ])'
            // 
            
            #if TODO
             given=  x = np.array({1e-6, 4e-7, 2, 3});
             given=  np.array_repr(x, precision=6, suppress_small=True);
             expected=
                "'array([ 0.000001,  0.      ,  2.      ,  3.      ])'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void array_strTest()
        {
            // >>> np.array_str(np.arange(3))
            // '[0 1 2]'
            // 
            
            #if TODO
            var given=  np.array_str(np.arange(3));
            var expected=
                "'[0 1 2]'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void format_float_positionalTest()
        {
            // >>> np.format_float_positional(np.float32(np.pi))
            // '3.1415927'
            // >>> np.format_float_positional(np.float16(np.pi))
            // '3.14'
            // >>> np.format_float_positional(np.float16(0.3))
            // '0.3'
            // >>> np.format_float_positional(np.float16(0.3), unique=False, precision=10)
            // '0.3000488281'
            // 
            
            #if TODO
            var given=  np.format_float_positional(np.float32(np.pi));
            var expected=
                "'3.1415927'";
            Assert.AreEqual(expected, given.repr);
             given=  np.format_float_positional(np.float16(np.pi));
             expected=
                "'3.14'";
            Assert.AreEqual(expected, given.repr);
             given=  np.format_float_positional(np.float16(0.3));
             expected=
                "'0.3'";
            Assert.AreEqual(expected, given.repr);
             given=  np.format_float_positional(np.float16(0.3), unique=False, precision=10);
             expected=
                "'0.3000488281'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void format_float_scientificTest()
        {
            // >>> np.format_float_scientific(np.float32(np.pi))
            // '3.1415927e+00'
            // >>> s = np.float32(1.23e24)
            // >>> np.format_float_scientific(s, unique=False, precision=15)
            // '1.230000071797338e+24'
            // >>> np.format_float_scientific(s, exp_digits=4)
            // '1.23e+0024'
            // 
            
            #if TODO
            var given=  np.format_float_scientific(np.float32(np.pi));
            var expected=
                "'3.1415927e+00'";
            Assert.AreEqual(expected, given.repr);
             given=  s = np.float32(1.23e24);
             given=  np.format_float_scientific(s, unique=False, precision=15);
             expected=
                "'1.230000071797338e+24'";
            Assert.AreEqual(expected, given.repr);
             given=  np.format_float_scientific(s, exp_digits=4);
             expected=
                "'1.23e+0024'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void memmapTest()
        {
            // >>> data = np.arange(12, dtype='float32')
            // >>> data.resize((3,4))
            // 
            
            #if TODO
            var given=  data = np.arange(12, dtype='float32');
             given=  data.resize((3,4));
            #endif
            // This example uses a temporary file so that doctest doesn’t write
            // files to your directory. You would use a ‘normal’ filename.
            
            // >>> from tempfile import mkdtemp
            // >>> import os.path as path
            // >>> filename = path.join(mkdtemp(), 'newfile.dat')
            // 
            
            #if TODO
             given=  from tempfile import mkdtemp;
             given=  import os.path as path;
             given=  filename = path.join(mkdtemp(), 'newfile.dat');
            #endif
            // Create a memmap with dtype and shape that matches our data:
            
            // >>> fp = np.memmap(filename, dtype='float32', mode='w+', shape=(3,4))
            // >>> fp
            // memmap([[ 0.,  0.,  0.,  0.],
            //         [ 0.,  0.,  0.,  0.],
            //         [ 0.,  0.,  0.,  0.]], dtype=float32)
            // 
            
            #if TODO
             given=  fp = np.memmap(filename, dtype='float32', mode='w+', shape=(3,4));
             given=  fp;
            var expected=
                "memmap([[ 0.,  0.,  0.,  0.],\n" +
                "        [ 0.,  0.,  0.,  0.],\n" +
                "        [ 0.,  0.,  0.,  0.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Write data to memmap array:
            
            // >>> fp[:] = data[:]
            // >>> fp
            // memmap([[  0.,   1.,   2.,   3.],
            //         [  4.,   5.,   6.,   7.],
            //         [  8.,   9.,  10.,  11.]], dtype=float32)
            // 
            
            #if TODO
             given=  fp[:] = data[:];
             given=  fp;
             expected=
                "memmap([[  0.,   1.,   2.,   3.],\n" +
                "        [  4.,   5.,   6.,   7.],\n" +
                "        [  8.,   9.,  10.,  11.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> fp.filename == path.abspath(filename)
            // True
            // 
            
            #if TODO
             given=  fp.filename == path.abspath(filename);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Deletion flushes memory changes to disk before removing the object:
            
            // >>> del fp
            // 
            
            #if TODO
             given=  del fp;
            #endif
            // Load the memmap and verify data was stored:
            
            // >>> newfp = np.memmap(filename, dtype='float32', mode='r', shape=(3,4))
            // >>> newfp
            // memmap([[  0.,   1.,   2.,   3.],
            //         [  4.,   5.,   6.,   7.],
            //         [  8.,   9.,  10.,  11.]], dtype=float32)
            // 
            
            #if TODO
             given=  newfp = np.memmap(filename, dtype='float32', mode='r', shape=(3,4));
             given=  newfp;
             expected=
                "memmap([[  0.,   1.,   2.,   3.],\n" +
                "        [  4.,   5.,   6.,   7.],\n" +
                "        [  8.,   9.,  10.,  11.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Read-only memmap:
            
            // >>> fpr = np.memmap(filename, dtype='float32', mode='r', shape=(3,4))
            // >>> fpr.flags.writeable
            // False
            // 
            
            #if TODO
             given=  fpr = np.memmap(filename, dtype='float32', mode='r', shape=(3,4));
             given=  fpr.flags.writeable;
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Copy-on-write memmap:
            
            // >>> fpc = np.memmap(filename, dtype='float32', mode='c', shape=(3,4))
            // >>> fpc.flags.writeable
            // True
            // 
            
            #if TODO
             given=  fpc = np.memmap(filename, dtype='float32', mode='c', shape=(3,4));
             given=  fpc.flags.writeable;
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // It’s possible to assign to copy-on-write array, but values are only
            // written into the memory copy of the array, and not written to disk:
            
            // >>> fpc
            // memmap([[  0.,   1.,   2.,   3.],
            //         [  4.,   5.,   6.,   7.],
            //         [  8.,   9.,  10.,  11.]], dtype=float32)
            // >>> fpc[0,:] = 0
            // >>> fpc
            // memmap([[  0.,   0.,   0.,   0.],
            //         [  4.,   5.,   6.,   7.],
            //         [  8.,   9.,  10.,  11.]], dtype=float32)
            // 
            
            #if TODO
             given=  fpc;
             expected=
                "memmap([[  0.,   1.,   2.,   3.],\n" +
                "        [  4.,   5.,   6.,   7.],\n" +
                "        [  8.,   9.,  10.,  11.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
             given=  fpc[0,:] = 0;
             given=  fpc;
             expected=
                "memmap([[  0.,   0.,   0.,   0.],\n" +
                "        [  4.,   5.,   6.,   7.],\n" +
                "        [  8.,   9.,  10.,  11.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // File on disk is unchanged:
            
            // >>> fpr
            // memmap([[  0.,   1.,   2.,   3.],
            //         [  4.,   5.,   6.,   7.],
            //         [  8.,   9.,  10.,  11.]], dtype=float32)
            // 
            
            #if TODO
             given=  fpr;
             expected=
                "memmap([[  0.,   1.,   2.,   3.],\n" +
                "        [  4.,   5.,   6.,   7.],\n" +
                "        [  8.,   9.,  10.,  11.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Offset into a memmap:
            
            // >>> fpo = np.memmap(filename, dtype='float32', mode='r', offset=16)
            // >>> fpo
            // memmap([  4.,   5.,   6.,   7.,   8.,   9.,  10.,  11.], dtype=float32)
            // 
            
            #if TODO
             given=  fpo = np.memmap(filename, dtype='float32', mode='r', offset=16);
             given=  fpo;
             expected=
                "memmap([  4.,   5.,   6.,   7.,   8.,   9.,  10.,  11.], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Methods
            
        }
        
        
        [TestMethod]
        public void set_printoptionsTest()
        {
            // Floating point precision can be set:
            
            // >>> np.set_printoptions(precision=4)
            // >>> print(np.array([1.123456789]))
            // [ 1.1235]
            // 
            
            #if TODO
            var given=  np.set_printoptions(precision=4);
             given=  print(np.array({1.123456789}));
            var expected=
                "[ 1.1235]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Long arrays can be summarised:
            
            // >>> np.set_printoptions(threshold=5)
            // >>> print(np.arange(10))
            // [0 1 2 ..., 7 8 9]
            // 
            
            #if TODO
             given=  np.set_printoptions(threshold=5);
             given=  print(np.arange(10));
             expected=
                "[0 1 2 ..., 7 8 9]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Small results can be suppressed:
            
            // >>> eps = np.finfo(float).eps
            // >>> x = np.arange(4.)
            // >>> x**2 - (x + eps)**2
            // array([ -4.9304e-32,  -4.4409e-16,   0.0000e+00,   0.0000e+00])
            // >>> np.set_printoptions(suppress=True)
            // >>> x**2 - (x + eps)**2
            // array([-0., -0.,  0.,  0.])
            // 
            
            #if TODO
             given=  eps = np.finfo(float).eps;
             given=  x = np.arange(4.);
             given=  x**2 - (x + eps)**2;
             expected=
                "array([ -4.9304e-32,  -4.4409e-16,   0.0000e+00,   0.0000e+00])";
            Assert.AreEqual(expected, given.repr);
             given=  np.set_printoptions(suppress=True);
             given=  x**2 - (x + eps)**2;
             expected=
                "array([-0., -0.,  0.,  0.])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // A custom formatter can be used to display array elements as desired:
            
            // >>> np.set_printoptions(formatter={'all':lambda x: 'int: '+str(-x)})
            // >>> x = np.arange(3)
            // >>> x
            // array([int: 0, int: -1, int: -2])
            // >>> np.set_printoptions()  # formatter gets reset
            // >>> x
            // array([0, 1, 2])
            // 
            
            #if TODO
             given=  np.set_printoptions(formatter={'all':lambda x: 'int: '+str(-x)});
             given=  x = np.arange(3);
             given=  x;
             expected=
                "array([int: 0, int: -1, int: -2])";
            Assert.AreEqual(expected, given.repr);
             given=  np.set_printoptions()  # formatter gets reset;
             given=  x;
             expected=
                "array([0, 1, 2])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // To put back the default options, you can use:
            
            // >>> np.set_printoptions(edgeitems=3,infstr='inf',
            // ... linewidth=75, nanstr='nan', precision=8,
            // ... suppress=False, threshold=1000, formatter=None)
            // 
            
            #if TODO
             given=  np.set_printoptions(edgeitems=3,infstr='inf',;
             expected=
                "... linewidth=75, nanstr='nan', precision=8,\n" +
                "... suppress=False, threshold=1000, formatter=None)";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void set_string_functionTest()
        {
            // >>> def pprint(arr):
            // ...     return 'HA! - What are you going to do now?'
            // ...
            // >>> np.set_string_function(pprint)
            // >>> a = np.arange(10)
            // >>> a
            // HA! - What are you going to do now?
            // >>> print(a)
            // [0 1 2 3 4 5 6 7 8 9]
            // 
            
            #if TODO
            var given=  def pprint(arr):;
            var expected=
                "...     return 'HA! - What are you going to do now?'\n" +
                "...";
            Assert.AreEqual(expected, given.repr);
             given=  np.set_string_function(pprint);
             given=  a = np.arange(10);
             given=  a;
             expected=
                "HA! - What are you going to do now?";
            Assert.AreEqual(expected, given.repr);
             given=  print(a);
             expected=
                "[0 1 2 3 4 5 6 7 8 9]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // We can reset the function to the default:
            
            // >>> np.set_string_function(None)
            // >>> a
            // array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])
            // 
            
            #if TODO
             given=  np.set_string_function(None);
             given=  a;
             expected=
                "array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // repr affects either pretty printing or normal string representation.
            // Note that __repr__ is still affected by setting __str__
            // because the width of each array element in the returned string becomes
            // equal to the length of the result of __str__().
            
            // >>> x = np.arange(4)
            // >>> np.set_string_function(lambda x:'random', repr=False)
            // >>> x.__str__()
            // 'random'
            // >>> x.__repr__()
            // 'array([     0,      1,      2,      3])'
            // 
            
            #if TODO
             given=  x = np.arange(4);
             given=  np.set_string_function(lambda x:'random', repr=False);
             given=  x.__str__();
             expected=
                "'random'";
            Assert.AreEqual(expected, given.repr);
             given=  x.__repr__();
             expected=
                "'array([     0,      1,      2,      3])'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void base_reprTest()
        {
            // >>> np.base_repr(5)
            // '101'
            // >>> np.base_repr(6, 5)
            // '11'
            // >>> np.base_repr(7, base=5, padding=3)
            // '00012'
            // 
            
            #if TODO
            var given=  np.base_repr(5);
            var expected=
                "'101'";
            Assert.AreEqual(expected, given.repr);
             given=  np.base_repr(6, 5);
             expected=
                "'11'";
            Assert.AreEqual(expected, given.repr);
             given=  np.base_repr(7, base=5, padding=3);
             expected=
                "'00012'";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.base_repr(10, base=16)
            // 'A'
            // >>> np.base_repr(32, base=16)
            // '20'
            // 
            
            #if TODO
             given=  np.base_repr(10, base=16);
             expected=
                "'A'";
            Assert.AreEqual(expected, given.repr);
             given=  np.base_repr(32, base=16);
             expected=
                "'20'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void DataSourceTest()
        {
            // >>> ds = DataSource('/home/guido')
            // >>> urlname = 'http://www.google.com/index.html'
            // >>> gfile = ds.open('http://www.google.com/index.html')  # remote file
            // >>> ds.abspath(urlname)
            // '/home/guido/www.google.com/site/index.html'
            // 
            // >>> ds = DataSource(None)  # use with temporary file
            // >>> ds.open('/home/guido/foobar.txt')
            // <open file '/home/guido.foobar.txt', mode 'r' at 0x91d4430>
            // >>> ds.abspath('/home/guido/foobar.txt')
            // '/tmp/tmpy4pgsP/home/guido/foobar.txt'
            // 
            
            #if TODO
            var given=  ds = DataSource('/home/guido');
             given=  urlname = 'http://www.google.com/index.html';
             given=  gfile = ds.open('http://www.google.com/index.html')  # remote file;
             given=  ds.abspath(urlname);
            var expected=
                "'/home/guido/www.google.com/site/index.html'\n" +
                "";
            Assert.AreEqual(expected, given.repr);
             given=  ds = DataSource(None)  # use with temporary file;
             given=  ds.open('/home/guido/foobar.txt');
             expected=
                "<open file '/home/guido.foobar.txt', mode 'r' at 0x91d4430>";
            Assert.AreEqual(expected, given.repr);
             given=  ds.abspath('/home/guido/foobar.txt');
             expected=
                "'/tmp/tmpy4pgsP/home/guido/foobar.txt'";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Methods
            
        }
        
    }
}
